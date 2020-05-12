package peru.maps.mapaperu;

import androidx.appcompat.app.AppCompatActivity;
import androidx.core.app.ActivityCompat;
import androidx.core.content.ContextCompat;

import android.Manifest;
import android.app.Dialog;
import android.content.Context;
import android.content.pm.PackageManager;
import android.location.Location;
import android.location.LocationManager;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.CheckBox;
import android.widget.EditText;
import android.widget.Spinner;
import android.widget.TextView;
import android.widget.Toast;

import peru.maps.mapaperu.pojo.ObjTriaje;
import peru.maps.mapaperu.rest.ITriaje;
import peru.maps.mapaperu.rest.RestTriaje;
import peru.maps.mapaperu.tools.Constantes;
import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class TriajeActivity extends AppCompatActivity {

    EditText nomT, numDocT;
    Spinner departT, natioT, docT;
    Button consultT;
    CheckBox chk1, chk2, chk3, chk4, chk5, chk6;
    TextView LatiT,LongiT;
    private LocationManager ubicacion;
    private String PTipoTransaccion = "N";
    private ObjTriaje oObjTriajeSeleccionado = new ObjTriaje();
    private ITriaje oITriaje = null;
    //¿?
    Dialog oVentana;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_triaje);

        //Permiso Localizacion//

        int permissionCheck = ContextCompat.checkSelfPermission(this, Manifest.permission.ACCESS_FINE_LOCATION);

        if (permissionCheck == PackageManager.PERMISSION_DENIED) {
            if (ActivityCompat.shouldShowRequestPermissionRationale(this, Manifest.permission.ACCESS_FINE_LOCATION)) {

            } else {
                ActivityCompat.requestPermissions(this, new String[]{Manifest.permission.ACCESS_FINE_LOCATION,Manifest.permission.ACCESS_COARSE_LOCATION}, 1);
            }
        }

        //===================//

        nomT = findViewById(R.id.edtNomT);
        numDocT = findViewById(R.id.edtNumDocT);
        departT = findViewById(R.id.spnDepartT);
        natioT = findViewById(R.id.spnNatioT);
        docT = findViewById(R.id.spnDocT);
        chk1 = findViewById(R.id.chk1);
        chk2 = findViewById(R.id.chk2);
        chk3 = findViewById(R.id.chk3);
        chk4 = findViewById(R.id.chk4);
        chk5 = findViewById(R.id.chk5);
        chk6 = findViewById(R.id.chk6);
        LatiT = findViewById(R.id.latiT);
        LongiT = findViewById(R.id.longiT);
        consultT = findViewById(R.id.btnConsultT);

        //===================================//
        String[] depart = {"Amazonas", "Ancash", "Apurímac", "Arequipa", "Ayacucho", "Cajamarca", "Cusco", "Huancavelica", "Huánuco", "Ica\n" +
                "\n", "Junín", "La Libertad", "Lambayeque", "Lima", "Loreto", "Madre de Dios", "Moquegua", "Pasco", "Piura", "Puno", "San Martín", "Tacna", "Tumbes", "Ucayali"};

        ArrayAdapter<String> adapter = new ArrayAdapter<String>(this, android.R.layout.simple_spinner_dropdown_item, depart);
        departT.setAdapter(adapter);
        //===================================//
        String[] nationality = {"ANTIGUA Y BARBUDA", "ARGENTINA", "BAHAMAS", "BARBADOS", "BELICE", "BOLIVIA", "BRASIL", "CANADÁ", "CHILE",
                "COLOMBIA", "COSTA RICA", "CUBA", "DOMINICA", "REPÚBLICA DOMINICANA", "ECUADOR", "EL SALVADOR", "ESTADOS UNIDOS", "GRANADA",
                "GUATEMALA", "GUYANA", "HAITÍ", "HONDURAS", "JAMAICA", "MÉXICO", "NICARAGUA", "PANAMÁ", "PARAGUAY", "PERÚ", "PUERTO RICO", "SAN CRISTÓBAL Y NIEVES",
                "SANTA LUCÍA", "SAN VICENTE Y LAS GRANADINAS", "SURINAM", "TRINIDAD Y TOBAGO", "URUGUAY", "VENEZUELA"};

        ArrayAdapter<String> adapter1 = new ArrayAdapter<String>(this, android.R.layout.simple_spinner_dropdown_item, nationality);
        natioT.setAdapter(adapter1);

        //===================================//
        String[] document = {"DNI", "Carné de extranjería"};

        ArrayAdapter<String> adapter3 = new ArrayAdapter<String>(this, android.R.layout.simple_spinner_dropdown_item, document);
        docT.setAdapter(adapter3);
        //===================================//

        location();

        consultT.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if (PTipoTransaccion.equals(Constantes.GETRegistraModifica)) {
                    oObjTriajeSeleccionado.setIdTriaje(0);
                }
                oObjTriajeSeleccionado.setIdTriaje(0);
                oObjTriajeSeleccionado.setNombres(nomT.getText().toString());
                oObjTriajeSeleccionado.setDepartamento(departT.getSelectedItem().toString());
                oObjTriajeSeleccionado.setNacionalidad(natioT.getSelectedItem().toString());
                oObjTriajeSeleccionado.setTipoDocumento(docT.getSelectedItem().toString());
                oObjTriajeSeleccionado.setNumeroDocumento(numDocT.getText().toString());
                oObjTriajeSeleccionado.setRespuesta1(chk1.getText().toString());
                oObjTriajeSeleccionado.setRespuesta2(chk2.getText().toString());
                oObjTriajeSeleccionado.setRespuesta3(chk3.getText().toString());
                oObjTriajeSeleccionado.setRespuesta4(chk4.getText().toString());
                oObjTriajeSeleccionado.setRespuesta5(chk5.getText().toString());
                oObjTriajeSeleccionado.setRespuesta6(chk6.getText().toString());
                oObjTriajeSeleccionado.setLatitud(LatiT.getText().toString());
                oObjTriajeSeleccionado.setLongitud(LongiT.getText().toString());

                RegistraModificaTriaje(oObjTriajeSeleccionado);

            }
        });

    }


    public void location() {
        if (ActivityCompat.checkSelfPermission(this, Manifest.permission.ACCESS_FINE_LOCATION) != PackageManager.PERMISSION_GRANTED && ActivityCompat.checkSelfPermission(this, Manifest.permission.ACCESS_COARSE_LOCATION) != PackageManager.PERMISSION_GRANTED) {

        }
        ubicacion = (LocationManager) getSystemService(Context.LOCATION_SERVICE);
        Location loc = ubicacion.getLastKnownLocation(LocationManager.GPS_PROVIDER);
        if(ubicacion != null){
            Log.d("Latitud",String.valueOf(loc.getLatitude()));
            Log.d("Longitud",String.valueOf(loc.getLongitude()));
            LatiT.setText(String.valueOf(loc.getLatitude()));
            LongiT.setText(String.valueOf(loc.getLongitude()));
        }
    }


    public void RegistraModificaTriaje(ObjTriaje pTriaje){
        oITriaje= RestTriaje.getRestTriaje().create(ITriaje.class);
        Call<ObjTriaje> call = oITriaje.getRegistraModifica(
                PTipoTransaccion, pTriaje.getIdTriaje(), pTriaje.getNombres(),pTriaje.getDepartamento()
                ,pTriaje.getNacionalidad(),pTriaje.getTipoDocumento(),pTriaje.getNumeroDocumento()
                ,pTriaje.getRespuesta1(),pTriaje.getRespuesta2(),pTriaje.getRespuesta3()
                ,pTriaje.getRespuesta4(),pTriaje.getRespuesta5(),pTriaje.getRespuesta6()
                ,pTriaje.getLatitud(),pTriaje.getLongitud()
        );
        call.enqueue(new Callback<ObjTriaje>() {

            @Override
            public void onResponse(Call<ObjTriaje> call, Response<ObjTriaje> response) {
                Log.d("body", response.body().toString());


                if (response.code() == 200) {
                    try {
                        oObjTriajeSeleccionado = response.body();
                        if (oObjTriajeSeleccionado.getCodigoError() != 0) {
                            Toast.makeText(getBaseContext(), "Sucedio un error  " +
                                    oObjTriajeSeleccionado.getDescripcionError(), Toast.LENGTH_LONG).show();
                        } else {
                            Toast.makeText(getBaseContext(), "Se registro correctamente " +
                                    oObjTriajeSeleccionado.getNombres(), Toast.LENGTH_LONG).show();
                            nomT.setText("");
                            departT.setSelection(Integer.parseInt(""));
                            natioT.setSelection(Integer.parseInt(""));
                            docT.setSelection(Integer.parseInt(""));
                            numDocT.setText("");
                            chk1.setText("");
                            chk2.setText("");
                            chk3.setText("");
                            chk4.setText("");
                            chk5.setText("");
                            chk6.setText("");
                            LatiT.setText("");
                            LongiT.setText("");
                            //ConsultaEncuesta();
                            oVentana.dismiss();
                        }
                    } catch (Exception e) {
                        Log.d("app", e.toString());
                    }
                }
            }

            public void onFailure(Call<ObjTriaje> call, Throwable t) {

                Log.d("ERROR", t.toString());
            }
        });
    }
}

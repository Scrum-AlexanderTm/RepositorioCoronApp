package peru.maps.mapaperu;

import androidx.appcompat.app.AppCompatActivity;

import android.app.Dialog;
import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Spinner;
import android.widget.Toast;

import peru.maps.mapaperu.pojo.ObjUsuario;
import peru.maps.mapaperu.rest.IUsuario;
import peru.maps.mapaperu.rest.RestUsuario;
import peru.maps.mapaperu.tools.Constantes;
import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class MainCitizenRegistration extends AppCompatActivity {

    EditText nomP,dateP;
    Spinner spinner1;
    Button btnContinuar;

    private String PTipoTransaccion = "N";
    private ObjUsuario oObjUsuarioSeleccionado = new ObjUsuario();
    private IUsuario oIUsuario = null;
    //¿?
    Dialog oVentana;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_citizen_registration);

        nomP = findViewById(R.id.edtNomP);
        dateP = findViewById(R.id.edtDateP);
        spinner1 = findViewById(R.id.spinnerP);
        btnContinuar = findViewById(R.id.btnContinuar);

        String[] opciones = {"DNI","Carné de extranjería"};

        ArrayAdapter <String> adapter = new ArrayAdapter<String>(this,android.R.layout.simple_spinner_dropdown_item,opciones);
        spinner1.setAdapter(adapter);

        /**Backup
         *btnContinuar.setOnClickListener(new View.OnClickListener() {
         *             @Override
         *             public void onClick(View view) {
         *
         *                 Toast.makeText(getApplicationContext(),"Datos Registrados Correctamente!!",Toast.LENGTH_SHORT).show();
         *                 Intent intent = new Intent(getApplicationContext(),MainBottomNavigation.class);
         *                 startActivity(intent);
         *             }
         *         });
         */

        btnContinuar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                if(PTipoTransaccion.equals(Constantes.GETRegistraModifica)){
                    oObjUsuarioSeleccionado.setIdUsuario(0);
                }
                oObjUsuarioSeleccionado.setIdUsuario(0);
                oObjUsuarioSeleccionado.setNombres(nomP.getText().toString());
                oObjUsuarioSeleccionado.setFechaNacimiento(dateP.getText().toString());
                oObjUsuarioSeleccionado.setTipoDocumento(spinner1.getSelectedItem().toString());

                RegistraModificaUsuario(oObjUsuarioSeleccionado);

                Intent intent = new Intent(getApplicationContext(),MainBottomNavigation.class);
                startActivity(intent);
            }
        });

    }

    public void RegistraModificaUsuario(ObjUsuario pUsuario) {
        oIUsuario= RestUsuario.getRestUsuario().create(IUsuario.class);
        Call<ObjUsuario> call = oIUsuario.getRegistraModifica(
                PTipoTransaccion, pUsuario.getIdUsuario(), pUsuario.getNombres(),pUsuario.getFechaNacimiento()
                ,pUsuario.getTipoDocumento()
        );
        call.enqueue(new Callback<ObjUsuario>() {

            @Override
            public void onResponse(Call<ObjUsuario> call, Response<ObjUsuario> response) {
                Log.d("body", response.body().toString());


                if (response.code() == 200) {
                    try {
                        oObjUsuarioSeleccionado = response.body();
                        if (oObjUsuarioSeleccionado.getCodigoError() != 0) {
                            Toast.makeText(getBaseContext(), "Sucedio un error  " +
                                    oObjUsuarioSeleccionado.getDescripcionError(), Toast.LENGTH_LONG).show();
                        } else {
                            Toast.makeText(getBaseContext(), "Se registro correctamente " +
                                    oObjUsuarioSeleccionado.getNombres(), Toast.LENGTH_LONG).show();
                            nomP.setText("");
                            dateP.setText("");;
                            spinner1.setSelection(Integer.parseInt(""));
                            //ConsultaEncuesta();
                            oVentana.dismiss();
                        }
                    } catch (Exception e) {
                        Log.d("app", e.toString());
                    }
                }
            }

            public void onFailure(Call<ObjUsuario> call, Throwable t) {

                Log.d("ERROR", t.toString());
            }
        });
    }

}

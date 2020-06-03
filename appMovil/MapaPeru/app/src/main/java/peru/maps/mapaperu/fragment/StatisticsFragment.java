package peru.maps.mapaperu.fragment;

import android.os.Bundle;

import androidx.fragment.app.Fragment;
import androidx.fragment.app.FragmentTransaction;

import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.TextView;

import java.util.List;

import peru.maps.mapaperu.R;
import peru.maps.mapaperu.VerCifrasDepartamentos;
import peru.maps.mapaperu.pojo.CifrasResponse;
import peru.maps.mapaperu.pojo.ObjListaCifra;
import peru.maps.mapaperu.rest.ICifras;
import peru.maps.mapaperu.rest.RestCifras;
import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

/**
 * A simple {@link Fragment} subclass.
 */
public class StatisticsFragment extends Fragment {

    /////////Mi codigo/////////
    private ICifras oICifras =null;
    private List<ObjListaCifra> ListaCifra=null;
    private TextView mjsonText=null;
    private TextView total = null;
    private TextView covid = null;
    private TextView hospi = null;
    private TextView muerto = null;
    private TextView recupe = null;
    private Button btnDepa;

    public StatisticsFragment() {
        // Required empty public constructor
    }


    @Override
    public View onCreateView(LayoutInflater inflater, final ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment
        View view = inflater.inflate(R.layout.fragment_statistics, container, false);

        total = view.findViewById(R.id.idPruebasTotalDepa);
        covid = view.findViewById(R.id.idCasosConDepa);
        hospi = view.findViewById(R.id.idHospitaDepa);
        muerto = view.findViewById(R.id.idMuertoDepa);
        recupe = view.findViewById(R.id.idRecupeDepa);
        btnDepa = view.findViewById(R.id.BtnDepart);





        btnDepa.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                showSelectedFragment(new VerCifrasDepartamentos());



            }
        });


        ListarReporte();
        return  view;

    }

    public void ListarReporte() {

        oICifras= RestCifras.getRestCifras().create(ICifras.class);
        Call<CifrasResponse> call=oICifras.getLista();

        call.enqueue(new Callback<CifrasResponse>() {
            @Override
            public void onResponse(Call<CifrasResponse> call, Response<CifrasResponse> response) {
                Log.d("body", response.body().toString());
                try {

                    CifrasResponse orpt = response.body();
                    ListaCifra = orpt.getObjListaCifras();
                    for(ObjListaCifra item: ListaCifra){

                        total.append(""+item.getPruebasRealizadas());
                        covid.append(""+ item.getCasosConfirmados());
                        hospi.append(""+ item.getHospitalizados());
                        muerto.append(""+ item.getFallecidos());
                        recupe.append(""+ item.getRecuperados());
                    }

                } catch (Exception e) {
                    Log.d("app",e.toString());
                }
            }

            @Override
            public void onFailure(Call<CifrasResponse> call, Throwable t) {
                Log.d("Error", t.toString());
                mjsonText.setText(t.getMessage());
            }


        });
    }

    private void showSelectedFragment(Fragment fragment){
        getFragmentManager().beginTransaction().replace(R.id.frame,fragment)
                .setTransition(FragmentTransaction.TRANSIT_FRAGMENT_FADE)
                .commit();
    }

}

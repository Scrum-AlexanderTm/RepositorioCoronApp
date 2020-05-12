package peru.maps.mapaperu.fragment;

import android.content.Intent;
import android.os.Bundle;

import androidx.fragment.app.Fragment;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;

import peru.maps.mapaperu.R;
import peru.maps.mapaperu.TriajeActivity;

/**
 * A simple {@link Fragment} subclass.
 */
public class TriajeFragment extends Fragment {

    View vista;
    Button btnEvaluacion1;

    public TriajeFragment() {
        // Required empty public constructor
    }


    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment
        vista = inflater.inflate(R.layout.fragment_triaje, container, false);

        btnEvaluacion1 = vista.findViewById(R.id.btnEvaluacion);

        btnEvaluacion1.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent = new Intent(getContext(), TriajeActivity.class);
                startActivity(intent);
            }
        });

        return vista;
    }
}

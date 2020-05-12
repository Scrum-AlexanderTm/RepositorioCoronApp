package peru.maps.mapaperu;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;

import androidx.appcompat.app.AppCompatActivity;

import com.google.firebase.auth.FirebaseAuth;

public class MainInicio extends AppCompatActivity{
    private FirebaseAuth mAuth;
    private EditText edtNumber;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_inicio);
        edtNumber= (EditText) findViewById(R.id.edtNumber);
        mAuth = FirebaseAuth.getInstance();

        findViewById(R.id.btnVerificar).setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                String number = edtNumber.getText().toString().trim();
                if(number.isEmpty()||number.length()<9){
                    edtNumber.setError("Número requerido");
                    edtNumber.requestFocus();
                    return;
                }
                //Agregar +51 y restringir el limite a 9 en activity
                String phoneNumber = "+51" + number;
                Intent intent = new Intent(MainInicio.this,MainVerificado.class);
                intent.putExtra("phonenumber",phoneNumber);
                startActivity(intent);
            }
        });

    }

    //Bloqueado hasta generar botón LOGOUT//
/**
 * /
 *      @Override
 *      protected void onStart() {
 *      super.onStart();
 *
 *      if (FirebaseAuth.getInstance().getCurrentUser() !=null){
 *      Intent intent = new Intent(this, MainBottomNavigation.class);
 *      intent.setFlags(Intent.FLAG_ACTIVITY_NEW_TASK | Intent.FLAG_ACTIVITY_CLEAR_TASK);
 *
 *      startActivity(intent);
 *         }
 *      }
 */


}

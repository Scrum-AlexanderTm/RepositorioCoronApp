package peru.maps.mapaperu;

import android.content.Intent;
import android.os.Bundle;
import android.view.Gravity;
import android.view.View;
import android.widget.EditText;
import android.widget.ProgressBar;
import android.widget.TextView;
import android.widget.Toast;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import com.google.android.gms.tasks.OnCompleteListener;
import com.google.android.gms.tasks.Task;
import com.google.android.gms.tasks.TaskExecutors;
import com.google.firebase.FirebaseException;
import com.google.firebase.auth.AuthResult;
import com.google.firebase.auth.FirebaseAuth;
import com.google.firebase.auth.PhoneAuthCredential;
import com.google.firebase.auth.PhoneAuthProvider;

import java.util.concurrent.TimeUnit;

public class MainVerificado extends AppCompatActivity {

    private String verificationId;
    private FirebaseAuth mAuth;
    private ProgressBar progressBar;
    private EditText edtCodigo;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_verificado);

        mAuth = FirebaseAuth.getInstance();

        progressBar = findViewById(R.id.progressBar);
        edtCodigo = findViewById(R.id.edtCodigo);

        String phonenumber = getIntent().getStringExtra("phonenumber");

        sendVerificationCode(phonenumber);

        findViewById(R.id.btnIngreso).setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                String code = edtCodigo.getText().toString().trim();
                if(code.isEmpty() || code.length() < 6){
                    edtCodigo.setError("Ingresar codigo...");
                    edtCodigo.requestFocus();
                    return;
                }

                verifyCode(code);
            }
        });
    }

    //EXCEPTION EN PROCESO
/**
 *private void verifyCode(String code){
 *         try {
 *             PhoneAuthCredential credential = PhoneAuthProvider.getCredential(verificationId,code);
 *             signInWithCredential(credential);
 *         }catch (Exception e){
 *         Toast toast = Toast.makeText(getApplicationContext(),"El código de verificación es incorrecto, intente nuevamente",Toast.LENGTH_SHORT);
 *         toast.setGravity(Gravity.CENTER,0,0);
 *         toast.show();
 *         }
 *     }
 */

    private void verifyCode(String code){
            PhoneAuthCredential credential = PhoneAuthProvider.getCredential(verificationId,code);
            signInWithCredential(credential);
    }

    private void signInWithCredential(PhoneAuthCredential credential) {
        mAuth.signInWithCredential(credential)
                .addOnCompleteListener(new OnCompleteListener<AuthResult>() {
                    @Override
                    public void onComplete(@NonNull Task<AuthResult> task) {
                        if (task.isSuccessful()){
                            Intent intent = new Intent(MainVerificado.this, MainCitizenRegistration.class);
                            intent.setFlags(Intent.FLAG_ACTIVITY_NEW_TASK | Intent.FLAG_ACTIVITY_CLEAR_TASK);

                            startActivity(intent);
                        }else{
                            Toast.makeText(MainVerificado.this,task.getException().getMessage(),Toast.LENGTH_LONG).show();
                        }
                    }
                });
    }

    private void sendVerificationCode(String number){
        progressBar.setVisibility(View.VISIBLE);
        PhoneAuthProvider.getInstance().verifyPhoneNumber(
                number,
                60,
                TimeUnit.SECONDS,
                TaskExecutors.MAIN_THREAD,
                mCallBack
        );
    }

    private PhoneAuthProvider.OnVerificationStateChangedCallbacks
            mCallBack = new PhoneAuthProvider.OnVerificationStateChangedCallbacks() {

        @Override
        public void onCodeSent(@NonNull String s, @NonNull PhoneAuthProvider.ForceResendingToken forceResendingToken) {
            super.onCodeSent(s, forceResendingToken);
            verificationId = s;
        }
        /*@Override
        public void onCodeSent(String s, PhoneAuthProvider.ForceResendingToken forceResendingToken) {
            super.onCodeSent(s, forceResendingToken);

            verificationId = s;
        }
        * */
        @Override
        public void onVerificationCompleted( PhoneAuthCredential phoneAuthCredential) {

            String code = phoneAuthCredential.getSmsCode();
            if(code != null){
                edtCodigo.setText(code);
                verifyCode(code);
            }
        }

        @Override
        public void onVerificationFailed( FirebaseException e) {
            Toast.makeText(MainVerificado.this,e.getMessage(), Toast.LENGTH_LONG).show();
        }
    };
}

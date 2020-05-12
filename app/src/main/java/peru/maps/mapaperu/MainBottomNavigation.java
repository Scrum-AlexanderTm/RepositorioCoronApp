package peru.maps.mapaperu;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;
import androidx.fragment.app.Fragment;
import androidx.fragment.app.FragmentTransaction;

import android.content.Intent;
import android.os.Bundle;
import android.view.MenuItem;

import com.google.android.material.bottomnavigation.BottomNavigationView;

import peru.maps.mapaperu.fragment.StatisticsFragment;
import peru.maps.mapaperu.fragment.TriajeFragment;

public class MainBottomNavigation extends AppCompatActivity {

    BottomNavigationView mbottomNavigation;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_bottom_navigaton);

        showSelectedFragment(new TriajeFragment());

        mbottomNavigation = findViewById(R.id.bottom_navigation);

        mbottomNavigation.setOnNavigationItemSelectedListener(new BottomNavigationView.OnNavigationItemSelectedListener() {
            @Override
            public boolean onNavigationItemSelected(@NonNull MenuItem item) {

                if (item.getItemId() == R.id.menu_triaje){
                    showSelectedFragment(new TriajeFragment());
                }

                if (item.getItemId() == R.id.menu_maps){

                }

                if (item.getItemId() == R.id.menu_statistics){
                    showSelectedFragment(new StatisticsFragment());
                }

                return true;
            }
        });
    }


    private void showSelectedFragment(Fragment fragment){
        getSupportFragmentManager().beginTransaction().replace(R.id.frame,fragment)
                .setTransition(FragmentTransaction.TRANSIT_FRAGMENT_FADE)
                .commit();
    }
}

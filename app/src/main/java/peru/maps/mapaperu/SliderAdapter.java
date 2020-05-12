package peru.maps.mapaperu;

import android.content.Context;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.RelativeLayout;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.viewpager.widget.PagerAdapter;

public class SliderAdapter extends PagerAdapter {

    Context context;
    LayoutInflater layoutInflater;

    public SliderAdapter(Context  context){
        this.context = context;
    }

    //Arrays
    public int[] slide_images={
            R.drawable.survey,
            R.drawable.stethoscope,
            R.drawable.doctor
    };

    public String[] slide_headings = {
            "INFORMACIÓN",
            "AUTODIAGNÓSTICO",
            "NOTIFICACIONES"
    };

    public String[] slide_descs = {

            "Al recolectar a diario los datos de tus sintomas podemos localizar focos de contagio,"+
                    " ayudar a frenar el virus y salvar vidas",
            "Haz aquí tu autodiagnóstico y el de tus familliares, incluso si se encuentran bien."+
                    " Invita a que otros lo hagan",
            "CoronaApp brinda datos oficiales sobre el Coronavirus en Perú. Alerta con notificaciones"+
                    " sobre la presencia del virus en tu zona."
    };

    @Override
    public int getCount() {
        return slide_headings.length;
    }

    @Override
    public boolean isViewFromObject(@NonNull View view, @NonNull Object object) {
        return view == (RelativeLayout) object;
    }

    @NonNull
    @Override
    public Object instantiateItem(@NonNull ViewGroup container, int position) {
        layoutInflater = (LayoutInflater) context.getSystemService(context.LAYOUT_INFLATER_SERVICE);
        View view = layoutInflater.inflate(R.layout.slide_layout,container,false);

        ImageView slideImageView = (ImageView) view.findViewById(R.id.slide_image);
        TextView slideHeading = (TextView) view.findViewById(R.id.slide_heading);
        TextView slideDescription = (TextView) view.findViewById(R.id.slide_desc);

        slideImageView.setImageResource(slide_images[position]);
        slideHeading.setText(slide_headings[position]);
        slideDescription.setText(slide_descs[position]);

        container.addView(view);
        return view;
    }

    @Override
    public void destroyItem(@NonNull ViewGroup container, int position, @NonNull Object object) {
        container.removeView((RelativeLayout)object);
    }
}

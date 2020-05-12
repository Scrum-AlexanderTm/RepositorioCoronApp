package peru.maps.mapaperu.pojo;

import android.os.Parcel;
import android.os.Parcelable;

import com.google.gson.annotations.Expose;
import com.google.gson.annotations.SerializedName;

import java.io.Serializable;

public class TriajeResponse implements Serializable, Parcelable {

    @SerializedName("ObjTriaje")
    @Expose
    private ObjTriaje objTriaje;

    protected TriajeResponse(Parcel in) {
        this.objTriaje = ((ObjTriaje) in.readValue((ObjTriaje.class.getClassLoader())));
    }

    public final static Creator<TriajeResponse> CREATOR = new Creator<TriajeResponse>() {

        @SuppressWarnings({
                "unchecked"
        })
        public TriajeResponse createFromParcel(Parcel in) {
            return new TriajeResponse(in);
        }

        public TriajeResponse[] newArray(int size) {
            return (new TriajeResponse[size]);
        }

    };

    private final static long serialVersionUID = -9040004016562114823L;


    @Override
    public int describeContents() { return 0; }

    @Override
    public void writeToParcel(Parcel parcel, int i) {
        parcel.writeParcelable(objTriaje, i);
    }
}
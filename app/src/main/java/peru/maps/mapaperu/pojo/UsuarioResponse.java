package peru.maps.mapaperu.pojo;

import android.os.Parcel;
import android.os.Parcelable;

import com.google.gson.annotations.Expose;
import com.google.gson.annotations.SerializedName;

import java.io.Serializable;

public class UsuarioResponse implements Serializable, Parcelable {

    @SerializedName("ObjUsuario")
    @Expose
    private ObjUsuario objUsuario;

    protected UsuarioResponse(Parcel in) {
        this.objUsuario = ((ObjUsuario) in.readValue((ObjUsuario.class.getClassLoader())));
    }

    public final static Creator<UsuarioResponse> CREATOR = new Creator<UsuarioResponse>() {

        @SuppressWarnings({
                "unchecked"
        })
        public UsuarioResponse createFromParcel(Parcel in) {
            return new UsuarioResponse(in);
        }

        public UsuarioResponse[] newArray(int size) {
            return (new UsuarioResponse[size]);
        }

    };

    private final static long serialVersionUID = -9040004016562114823L;


    @Override
    public int describeContents() { return 0; }

    @Override
    public void writeToParcel(Parcel parcel, int i) {
        parcel.writeParcelable(objUsuario, i);
    }
}

package peru.maps.mapaperu.pojo;

import android.os.Parcel;
import android.os.Parcelable;

import com.google.gson.annotations.Expose;
import com.google.gson.annotations.SerializedName;

import java.io.Serializable;
import java.util.List;

public class CifrasResponse implements Serializable, Parcelable
{

    @SerializedName("ObjCifras")
    @Expose
    private ObjCifras objCifras;
    @SerializedName("ObjListaCifras")
    @Expose
    private List<ObjListaCifra> objListaCifras = null;
    public final static Creator<CifrasResponse> CREATOR = new Creator<CifrasResponse>() {


        @SuppressWarnings({
                "unchecked"
        })
        public CifrasResponse createFromParcel(Parcel in) {
            return new CifrasResponse(in);
        }

        public CifrasResponse[] newArray(int size) {
            return (new CifrasResponse[size]);
        }

    }
            ;
    private final static long serialVersionUID = 5822829087389618541L;

    protected CifrasResponse(Parcel in) {
        this.objCifras = ((ObjCifras) in.readValue((ObjCifras.class.getClassLoader())));
        in.readList(this.objListaCifras, (peru.maps.mapaperu.pojo.ObjListaCifra.class.getClassLoader()));
    }

    public CifrasResponse() {
    }

    public ObjCifras getObjCifras() {
        return objCifras;
    }

    public void setObjCifras(ObjCifras objCifras) {
        this.objCifras = objCifras;
    }

    public List<ObjListaCifra> getObjListaCifras() {
        return objListaCifras;
    }

    public void setObjListaCifras(List<ObjListaCifra> objListaCifras) {
        this.objListaCifras = objListaCifras;
    }

    public void writeToParcel(Parcel dest, int flags) {
        dest.writeValue(objCifras);
        dest.writeList(objListaCifras);
    }

    public int describeContents() {
        return  0;
    }

}


package peru.maps.mapaperu.pojo;

import android.os.Parcel;
import android.os.Parcelable;

import com.google.gson.annotations.Expose;
import com.google.gson.annotations.SerializedName;

import java.io.Serializable;

public class ObjCifras implements Serializable, Parcelable
{

    @SerializedName("IdCifras")
    @Expose
    private Integer idCifras;
    @SerializedName("PruebasRealizadas")
    @Expose
    private Integer pruebasRealizadas;
    @SerializedName("CasosConfirmados")
    @Expose
    private Integer casosConfirmados;
    @SerializedName("Hospitalizados")
    @Expose
    private Integer hospitalizados;
    @SerializedName("Recuperados")
    @Expose
    private Integer recuperados;
    @SerializedName("Fallecidos")
    @Expose
    private Integer fallecidos;
    @SerializedName("IdTriaje")
    @Expose
    private Integer idTriaje;
    @SerializedName("Eliminado")
    @Expose
    private Boolean eliminado;
    @SerializedName("CodigoError")
    @Expose
    private Integer codigoError;
    @SerializedName("DescripcionError")
    @Expose
    private String descripcionError;
    @SerializedName("MensajeError")
    @Expose
    private Object mensajeError;
    public final static Creator<ObjCifras> CREATOR = new Creator<ObjCifras>() {


        @SuppressWarnings({
            "unchecked"
        })
        public ObjCifras createFromParcel(Parcel in) {
            return new ObjCifras(in);
        }

        public ObjCifras[] newArray(int size) {
            return (new ObjCifras[size]);
        }

    }
    ;
    private final static long serialVersionUID = 2894799888194467646L;

    protected ObjCifras(Parcel in) {
        this.idCifras = ((Integer) in.readValue((Integer.class.getClassLoader())));
        this.pruebasRealizadas = ((Integer) in.readValue((Integer.class.getClassLoader())));
        this.casosConfirmados = ((Integer) in.readValue((Integer.class.getClassLoader())));
        this.hospitalizados = ((Integer) in.readValue((Integer.class.getClassLoader())));
        this.recuperados = ((Integer) in.readValue((Integer.class.getClassLoader())));
        this.fallecidos = ((Integer) in.readValue((Integer.class.getClassLoader())));
        this.idTriaje = ((Integer) in.readValue((Integer.class.getClassLoader())));
        this.eliminado = ((Boolean) in.readValue((Boolean.class.getClassLoader())));
        this.codigoError = ((Integer) in.readValue((Integer.class.getClassLoader())));
        this.descripcionError = ((String) in.readValue((String.class.getClassLoader())));
        this.mensajeError = ((Object) in.readValue((Object.class.getClassLoader())));
    }

    public ObjCifras() {
    }

    public Integer getIdCifras() {
        return idCifras;
    }

    public void setIdCifras(Integer idCifras) {
        this.idCifras = idCifras;
    }

    public Integer getPruebasRealizadas() {
        return pruebasRealizadas;
    }

    public void setPruebasRealizadas(Integer pruebasRealizadas) {
        this.pruebasRealizadas = pruebasRealizadas;
    }

    public Integer getCasosConfirmados() {
        return casosConfirmados;
    }

    public void setCasosConfirmados(Integer casosConfirmados) {
        this.casosConfirmados = casosConfirmados;
    }

    public Integer getHospitalizados() {
        return hospitalizados;
    }

    public void setHospitalizados(Integer hospitalizados) {
        this.hospitalizados = hospitalizados;
    }

    public Integer getRecuperados() {
        return recuperados;
    }

    public void setRecuperados(Integer recuperados) {
        this.recuperados = recuperados;
    }

    public Integer getFallecidos() {
        return fallecidos;
    }

    public void setFallecidos(Integer fallecidos) {
        this.fallecidos = fallecidos;
    }

    public Integer getIdTriaje() {
        return idTriaje;
    }

    public void setIdTriaje(Integer idTriaje) {
        this.idTriaje = idTriaje;
    }

    public Boolean getEliminado() {
        return eliminado;
    }

    public void setEliminado(Boolean eliminado) {
        this.eliminado = eliminado;
    }

    public Integer getCodigoError() {
        return codigoError;
    }

    public void setCodigoError(Integer codigoError) {
        this.codigoError = codigoError;
    }

    public String getDescripcionError() {
        return descripcionError;
    }

    public void setDescripcionError(String descripcionError) {
        this.descripcionError = descripcionError;
    }

    public Object getMensajeError() {
        return mensajeError;
    }

    public void setMensajeError(Object mensajeError) {
        this.mensajeError = mensajeError;
    }

    public void writeToParcel(Parcel dest, int flags) {
        dest.writeValue(idCifras);
        dest.writeValue(pruebasRealizadas);
        dest.writeValue(casosConfirmados);
        dest.writeValue(hospitalizados);
        dest.writeValue(recuperados);
        dest.writeValue(fallecidos);
        dest.writeValue(idTriaje);
        dest.writeValue(eliminado);
        dest.writeValue(codigoError);
        dest.writeValue(descripcionError);
        dest.writeValue(mensajeError);
    }

    public int describeContents() {
        return  0;
    }

}

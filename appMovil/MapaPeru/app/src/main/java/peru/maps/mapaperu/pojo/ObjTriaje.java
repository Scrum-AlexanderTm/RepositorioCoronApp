package peru.maps.mapaperu.pojo;

import android.os.Parcel;
import android.os.Parcelable;

import com.google.gson.annotations.Expose;
import com.google.gson.annotations.SerializedName;

import java.io.Serializable;

public class ObjTriaje implements Serializable, Parcelable
{

    @SerializedName("IdTriaje")
    @Expose
    private Integer idTriaje;
    @SerializedName("Nombres")
    @Expose
    private String nombres;
    @SerializedName("Departamento")
    @Expose
    private String departamento;
    @SerializedName("Nacionalidad")
    @Expose
    private String nacionalidad;
    @SerializedName("TipoDocumento")
    @Expose
    private String tipoDocumento;
    @SerializedName("NumeroDocumento")
    @Expose
    private String numeroDocumento;
    @SerializedName("Respuesta1")
    @Expose
    private String respuesta1;
    @SerializedName("Respuesta2")
    @Expose
    private String respuesta2;
    @SerializedName("Respuesta3")
    @Expose
    private String respuesta3;
    @SerializedName("Respuesta4")
    @Expose
    private String respuesta4;
    @SerializedName("Respuesta5")
    @Expose
    private String respuesta5;
    @SerializedName("Respuesta6")
    @Expose
    private String respuesta6;
    @SerializedName("Latitud")
    @Expose
    private String latitud;
    @SerializedName("Longitud")
    @Expose
    private String longitud;
    //================================//

    @SerializedName("FechaTriaje")
    @Expose
    private String fechaTriaje;
    @SerializedName("IdMapa")
    @Expose
    private Integer idMapa;

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

    public final static Creator<ObjTriaje> CREATOR = new Creator<ObjTriaje>() {

        @SuppressWarnings({
                "unchecked"
        })
        public ObjTriaje createFromParcel(Parcel in) {
            return new ObjTriaje(in);
        }

        public ObjTriaje[] newArray(int size) {
            return (new ObjTriaje[size]);
        }
    };

    private final static long serialVersionUID = 5509337037080445727L;

    protected ObjTriaje(Parcel in) {
        this.idTriaje = ((Integer) in.readValue((Integer.class.getClassLoader())));
        this.nombres = ((String) in.readValue((String.class.getClassLoader())));
        this.departamento = ((String) in.readValue((String.class.getClassLoader())));
        this.nacionalidad = ((String) in.readValue((String.class.getClassLoader())));
        this.tipoDocumento = ((String) in.readValue((String.class.getClassLoader())));
        this.numeroDocumento = ((String) in.readValue((String.class.getClassLoader())));
        this.respuesta1 = ((String) in.readValue((String.class.getClassLoader())));
        this.respuesta2 = ((String) in.readValue((String.class.getClassLoader())));
        this.respuesta3 = ((String) in.readValue((String.class.getClassLoader())));
        this.respuesta4 = ((String) in.readValue((String.class.getClassLoader())));
        this.respuesta5 = ((String) in.readValue((String.class.getClassLoader())));
        this.respuesta6 = ((String) in.readValue((String.class.getClassLoader())));
        this.latitud = ((String) in.readValue((String.class.getClassLoader())));
        this.longitud = ((String) in.readValue((String.class.getClassLoader())));
        this.fechaTriaje = ((String) in.readValue((String.class.getClassLoader())));
        this.idMapa = ((Integer) in.readValue((Integer.class.getClassLoader())));
        this.eliminado = ((Boolean) in.readValue((Boolean.class.getClassLoader())));
        this.codigoError = ((Integer) in.readValue((Integer.class.getClassLoader())));
        this.descripcionError = ((String) in.readValue((String.class.getClassLoader())));
        this.mensajeError = ((Object) in.readValue((Object.class.getClassLoader())));
    }

    public ObjTriaje() {
    }

    public Integer getIdTriaje() {
        return idTriaje;
    }

    public void setIdTriaje(Integer idTriaje) {
        this.idTriaje = idTriaje;
    }

    public String getNombres() {
        return nombres;
    }

    public void setNombres(String nombres) {
        this.nombres = nombres;
    }

    public String getDepartamento() {
        return departamento;
    }

    public void setDepartamento(String departamento) {
        this.departamento = departamento;
    }

    public String getNacionalidad() {
        return nacionalidad;
    }

    public void setNacionalidad(String nacionalidad) {
        this.nacionalidad = nacionalidad;
    }

    public String getTipoDocumento() {
        return tipoDocumento;
    }

    public void setTipoDocumento(String tipoDocumento) {
        this.tipoDocumento = tipoDocumento;
    }

    public String getNumeroDocumento() {
        return numeroDocumento;
    }

    public void setNumeroDocumento(String numeroDocumento) { this.numeroDocumento = numeroDocumento; }

    public String getRespuesta1() {
        return respuesta1;
    }

    public void setRespuesta1(String respuesta1) {
        this.respuesta1 = respuesta1;
    }

    public String getRespuesta2() {
        return respuesta2;
    }

    public void setRespuesta2(String respuesta2) {
        this.respuesta2 = respuesta2;
    }

    public String getRespuesta3() {
        return respuesta3;
    }

    public void setRespuesta3(String respuesta3) { this.respuesta3 = respuesta3; }

    public String getRespuesta4() {
        return respuesta4;
    }

    public void setRespuesta4(String respuesta4) {
        this.respuesta4 = respuesta4;
    }

    public String getRespuesta5() {
        return respuesta5;
    }

    public void setRespuesta5(String respuesta5) {
        this.respuesta5 = respuesta5;
    }

    public String getRespuesta6() {
        return respuesta6;
    }

    public void setRespuesta6(String respuesta6) {
        this.respuesta6 = respuesta6;
    }

    public String getLatitud() {
        return latitud;
    }

    public void setLatitud(String latitud) {
        this.latitud = latitud;
    }

    public String getLongitud() {
        return longitud;
    }

    public void setLongitud(String longitud) {
        this.longitud = longitud;
    }

    public String getFechaTriaje() {
        return fechaTriaje;
    }

    public void setFechaTriaje(String fechaTriaje) {
        this.fechaTriaje = fechaTriaje;
    }

    public Integer getIdMapa() {
        return idMapa;
    }

    public void setIdMapa(Integer idMapa) {
        this.idMapa = idMapa;
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
        dest.writeValue(idTriaje);
        dest.writeValue(nombres);
        dest.writeValue(departamento);
        dest.writeValue(nacionalidad);
        dest.writeValue(tipoDocumento);
        dest.writeValue(numeroDocumento);
        dest.writeValue(respuesta1);
        dest.writeValue(respuesta2);
        dest.writeValue(respuesta3);
        dest.writeValue(respuesta4);
        dest.writeValue(respuesta5);
        dest.writeValue(respuesta6);
        dest.writeValue(latitud);
        dest.writeValue(longitud);
        dest.writeValue(fechaTriaje);
        dest.writeValue(idMapa);
        dest.writeValue(eliminado);
        dest.writeValue(codigoError);
        dest.writeValue(descripcionError);
        dest.writeValue(mensajeError);
    }

    public int describeContents() {
        return  0;
    }

}

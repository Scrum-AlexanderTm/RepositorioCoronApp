package peru.maps.mapaperu.pojo;

import android.os.Parcel;
import android.os.Parcelable;

import com.google.gson.annotations.Expose;
import com.google.gson.annotations.SerializedName;

import java.io.Serializable;

public class ObjUsuario implements Serializable, Parcelable
{

    @SerializedName("IdUsuario")
    @Expose
    private Integer idUsuario;
    @SerializedName("Nombres")
    @Expose
    private String nombres;
    @SerializedName("FechaNacimiento")
    @Expose
    private String fechaNacimiento;
    @SerializedName("TipoDocumento")
    @Expose
    private String tipoDocumento;

    //================================//
    @SerializedName("Nacionalidad")
    @Expose
    private String nacionalidad;
    @SerializedName("NumeroDocumento")
    @Expose
    private String numeroDocumento;
    @SerializedName("Telefono")
    @Expose
    private String telefono;
    //================================//
    //*********About to see*********//
    @SerializedName("FechaRegistro")
    @Expose
    private String fechaRegistro;
    @SerializedName("IdRol")
    @Expose
    private Integer idRol;
    @SerializedName("Login")
    @Expose
    private String login;
    @SerializedName("Clave")
    @Expose
    private String clave;
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
    //*********About to see*********//

    public final static Creator<ObjUsuario> CREATOR = new Creator<ObjUsuario>() {

        @SuppressWarnings({
                "unchecked"
        })
        public ObjUsuario createFromParcel(Parcel in) {
            return new ObjUsuario(in);
        }

        public ObjUsuario[] newArray(int size) {
            return (new ObjUsuario[size]);
        }

    }
            ;
    private final static long serialVersionUID = 5509337037080445727L;

    protected ObjUsuario(Parcel in) {
        this.idUsuario = ((Integer) in.readValue((Integer.class.getClassLoader())));
        this.nombres = ((String) in.readValue((String.class.getClassLoader())));
        this.fechaNacimiento = ((String) in.readValue((String.class.getClassLoader())));
        this.nacionalidad = ((String) in.readValue((String.class.getClassLoader())));
        this.tipoDocumento = ((String) in.readValue((String.class.getClassLoader())));
        this.numeroDocumento = ((String) in.readValue((String.class.getClassLoader())));
        this.telefono = ((String) in.readValue((String.class.getClassLoader())));
        this.fechaRegistro = ((String) in.readValue((String.class.getClassLoader())));
        this.idRol = ((Integer) in.readValue((Integer.class.getClassLoader())));
        this.login = ((String) in.readValue((String.class.getClassLoader())));
        this.clave = ((String) in.readValue((String.class.getClassLoader())));
        this.eliminado = ((Boolean) in.readValue((Boolean.class.getClassLoader())));
        this.codigoError = ((Integer) in.readValue((Integer.class.getClassLoader())));
        this.descripcionError = ((String) in.readValue((String.class.getClassLoader())));
        this.mensajeError = ((Object) in.readValue((Object.class.getClassLoader())));
    }

    public ObjUsuario() {
    }

    public Integer getIdUsuario() {
        return idUsuario;
    }

    public void setIdUsuario(Integer idUsuario) {
        this.idUsuario = idUsuario;
    }

    public String getNombres() {
        return nombres;
    }

    public void setNombres(String nombres) {
        this.nombres = nombres;
    }

    public String getFechaNacimiento() {
        return fechaNacimiento;
    }

    public void setFechaNacimiento(String fechaNacimiento) {
        this.fechaNacimiento = fechaNacimiento;
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

    public void setNumeroDocumento(String numeroDocumento) {
        this.numeroDocumento = numeroDocumento;
    }

    public String getTelefono() {
        return telefono;
    }

    public void setTelefono(String telefono) {
        this.telefono = telefono;
    }

    public String getFechaRegistro() {
        return fechaRegistro;
    }

    public void setFechaRegistro(String fechaRegistro) {
        this.fechaRegistro = fechaRegistro;
    }

    public Integer getIdRol() {
        return idRol;
    }

    public void setIdRol(Integer idRol) {
        this.idRol = idRol;
    }

    public String getLogin() {
        return login;
    }

    public void setLogin(String login) {
        this.login = login;
    }

    public String getClave() {
        return clave;
    }

    public void setClave(String clave) {
        this.clave = clave;
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
        dest.writeValue(idUsuario);
        dest.writeValue(nombres);
        dest.writeValue(fechaNacimiento);
        dest.writeValue(nacionalidad);
        dest.writeValue(tipoDocumento);
        dest.writeValue(numeroDocumento);
        dest.writeValue(telefono);
        dest.writeValue(fechaRegistro);
        dest.writeValue(idRol);
        dest.writeValue(login);
        dest.writeValue(clave);
        dest.writeValue(eliminado);
        dest.writeValue(codigoError);
        dest.writeValue(descripcionError);
        dest.writeValue(mensajeError);
    }

    public int describeContents() {
        return  0;
    }

}

package peru.maps.mapaperu.rest;

import peru.maps.mapaperu.pojo.ObjTriaje;
import peru.maps.mapaperu.pojo.ObjUsuario;
import peru.maps.mapaperu.tools.Constantes;
import retrofit2.Call;
import retrofit2.http.GET;
import retrofit2.http.Headers;
import retrofit2.http.Query;

public interface IUsuario {

    @GET(Constantes.GETRegistraModifica)
    @Headers({ "Content-Type: application/json"})
    Call<ObjUsuario> getRegistraModifica(
            @Query(value = "pTipoTransaccion") String pTipoTransaccion,
            @Query(value = "IdUsuario") int IdUsuario,
            @Query(value = "Nombres") String Nombres,
            @Query(value = "FechaNacimiento") String FechaNacimiento,
            @Query(value = "TipoDocumento") String TipoDocumento
    );

}

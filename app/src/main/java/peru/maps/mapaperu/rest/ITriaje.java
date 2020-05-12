package peru.maps.mapaperu.rest;

import peru.maps.mapaperu.pojo.ObjTriaje;
import peru.maps.mapaperu.tools.Constantes;
import retrofit2.Call;
import retrofit2.http.GET;
import retrofit2.http.Headers;
import retrofit2.http.Query;

public interface ITriaje {

    //About to see
    //=======Add answers=======
    @GET(Constantes.GETRegistraModifica)
    @Headers({ "Content-Type: application/json"})
    Call<ObjTriaje> getRegistraModifica(
            @Query(value = "pTipoTransaccion") String pTipoTransaccion,
            @Query(value = "IdTriaje") int IdTriaje,
            @Query(value = "Nombres") String Nombres,
            @Query(value = "Departamento") String Departamento,
            @Query(value = "Nacionalidad") String Nacionalidad,
            @Query(value = "TipoDocumento") String TipoDocumento,
            @Query(value = "NumeroDocumento") String NumeroDocumento,
            @Query(value = "Respuesta1") String Respuesta1,
            @Query(value = "Respuesta2") String Respuesta2,
            @Query(value = "Respuesta3") String Respuesta3,
            @Query(value = "Respuesta4") String Respuesta4,
            @Query(value = "Respuesta5") String Respuesta5,
            @Query(value = "Respuesta6") String Respuesta6,
            @Query(value = "Latitud") String Latitud,
            @Query(value = "Longitud") String Longitud
    );
}

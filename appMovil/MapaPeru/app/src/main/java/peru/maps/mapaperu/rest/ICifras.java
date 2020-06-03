package peru.maps.mapaperu.rest;

import peru.maps.mapaperu.pojo.CifrasResponse;
import peru.maps.mapaperu.tools.Constantes;
import retrofit2.Call;
import retrofit2.http.GET;
import retrofit2.http.Headers;
import retrofit2.http.Query;

public interface ICifras {
    @GET(Constantes.GETLISTAREPORTE)
    @Headers({ "Content-Type: application/json"})
    Call<CifrasResponse> getLista(
    );

    @GET(Constantes.GETLISTAREPORTEDEP)
    @Headers({ "Content-Type: application/json"})

    Call<CifrasResponse> getListaDepartamento(@Query("pDepartamento") String depa
    );
}

import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';

const API_LOCATION = "http://localhost:64500/api/estudioabogados/abogado/items";

@Injectable()
export class AbogadoService {

  constructor(private http: HttpClient) { }

  getItems(): Observable<Abogado[]> {
    return this.http.get<Abogado[]>(API_LOCATION);
  }

}

export class Abogado {
  id: number;
  apPaterno: string;
  apMaterno: string;
  nombres: string;
  nroDocumento: string;
  codColegioAB: string;
}

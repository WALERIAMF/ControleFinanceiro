import { Tipo } from './Tipo';
export class Categoria{
  IdInterno: string = "";
  nome: string = "";
  icone: string = "";
  tipoId: string = "";
  tipo: Tipo | undefined;
}

namespace listas_arvores_exemplo_csharp.Exemplos {
    public class Filas {
        Fila fila, filaAux, filaUltima;

        public void Add(object item){
            Fila f = new Fila();
            f.Add(ref fila, ref filaAux, ref filaUltima, item);                     
        }

        public Fila GetFila(int posicao){
            Fila f = new Fila();
            return f.GetFila(ref fila, ref filaAux, ref filaUltima, posicao);
        }

    }

    public class Fila {
        
        public Fila proximo;

        public object item;

        public Fila(){}

        public void Add(ref Fila fila, ref Fila filaAux, ref Fila filaUltima,
                             object item){
            //lista = new Lista(lista, l2, item);    
            if (fila == null){
                fila = new Fila();
                fila.proximo = null;
                fila.item = item;
            } else {
                filaAux = fila;
                if (fila.proximo == null)
                   filaUltima = fila; 
                while (fila.proximo != null) {
                    filaUltima = fila.proximo;
                    fila = fila.proximo;		
                }
                fila = filaAux;
                filaUltima.proximo = new Fila();
                filaUltima.proximo.item = item;
            }
        }

        public Fila GetFila(ref Fila fila, ref Fila filaAux, ref Fila filaUltima,
                            int posicao){
            filaUltima = fila;
            Fila teste = fila;
            for (int i=-1; i != posicao; i++){
                filaAux = fila;
                fila = fila.proximo;    
            }
            fila = filaUltima;
            return filaAux;
        }


    }
}
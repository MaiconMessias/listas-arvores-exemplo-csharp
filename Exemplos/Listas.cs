namespace listas_arvores_exemplo_csharp.Exemplos {
    public class Listas {
        Lista lista, listaAux, listaUltima;

        public void Add(object item){
            Lista f = new Lista();
            f.Add(ref lista, ref listaAux, ref listaUltima, item);                     
        }

        public Lista GetItemLista(int posicao){
            Lista f = new Lista();
            return f.GetItemLista(ref lista, ref listaAux, ref listaUltima, posicao);
        }

    }

    public class Lista {
        
        public Lista proximo;

        public object item;

        public Lista(){}

        public void Add(ref Lista lista, ref Lista listaAux, ref Lista listaUltima,
                             object item){
            //lista = new Lista(lista, l2, item);    
            if (lista == null){
                lista = new Lista();
                lista.proximo = null;
                lista.item = item;
            } else {
                listaAux = lista;
                if (lista.proximo == null)
                   listaUltima = lista; 
                while (lista.proximo != null) {
                    listaUltima = lista.proximo;
                    lista = lista.proximo;		
                }
                lista = listaAux;
                listaUltima.proximo = new Lista();
                listaUltima.proximo.item = item;
            }
        }

        public Lista GetItemLista(ref Lista lista, ref Lista listaAux, ref Lista listaUltima,
                            int posicao){
            listaUltima = lista;
            Lista teste = lista;
            for (int i=-1; i != posicao; i++){
                listaAux = lista;
                lista = lista.proximo;    
            }
            lista = listaUltima;
            return listaAux;
        }


    }
}
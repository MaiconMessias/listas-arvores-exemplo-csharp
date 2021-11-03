namespace listas_arvores_exemplo_csharp.Exemplos {
    public class Arvores {

        Arvore primeiraArvore;
        
        public void Add(string item){
            Arvore a = new Arvore();
            a.Add(ref primeiraArvore, item);
        }

        public Arvore GetItemPrimeiraArvore(int posicao){
            Arvore a = new Arvore();
            Arvore retorno = a.GetItemPrimeiraArvore(ref primeiraArvore,  posicao);
            return retorno;
        }

        
    }

    public class Arvore{
        private Arvore primeiraArvore;
        private Arvore segundaArvore;
        private Arvore proximaArvore;
        public string item;		
        
        public Arvore(){}

        public void Add(ref Arvore primeiraArvore, string item){
            if (primeiraArvore == null){
                primeiraArvore = new Arvore();
                primeiraArvore.item = "root";
                primeiraArvore.primeiraArvore = new Arvore();	
                primeiraArvore.primeiraArvore.item = item;
            } else if (primeiraArvore.segundaArvore == null) {
                primeiraArvore.segundaArvore = new Arvore();		
                primeiraArvore.segundaArvore.item = item;
            } else {
                int qtdePA = 0; 	
                int qtdeSA = 0;
                Arvore primeiraAux;
                Arvore segundaAux;
                Arvore arvoreUltima = null;
                
                primeiraAux = primeiraArvore.primeiraArvore;
                while (primeiraArvore.primeiraArvore != null){
                    ++qtdePA;
                    primeiraArvore.primeiraArvore = primeiraArvore.primeiraArvore.proximaArvore;
                }
                primeiraArvore.primeiraArvore = primeiraAux;
                
                segundaAux = primeiraArvore.segundaArvore;
                while (primeiraArvore.segundaArvore != null){
                    ++qtdeSA;
                    primeiraArvore.segundaArvore = primeiraArvore.segundaArvore.proximaArvore;
                }
                primeiraArvore.segundaArvore = segundaAux;
                

                if (qtdePA < qtdeSA || qtdePA == qtdeSA){
                    primeiraAux = primeiraArvore.primeiraArvore;
                    if (primeiraArvore.primeiraArvore.proximaArvore == null)
                        arvoreUltima = primeiraArvore.primeiraArvore; 
                    while (primeiraArvore.primeiraArvore.proximaArvore != null) {
                        arvoreUltima = primeiraArvore.primeiraArvore.proximaArvore;
                        primeiraArvore.primeiraArvore = primeiraArvore.primeiraArvore.proximaArvore;		
                    }
                    primeiraArvore.primeiraArvore = primeiraAux;
                    arvoreUltima.proximaArvore = new Arvore();
                    arvoreUltima.proximaArvore.item = item;
                } else {                    
                    segundaAux = primeiraArvore.segundaArvore;
                    if (primeiraArvore.segundaArvore.proximaArvore == null)
                        arvoreUltima = primeiraArvore.segundaArvore; 
                    while (primeiraArvore.segundaArvore.proximaArvore != null) {
                        arvoreUltima = primeiraArvore.segundaArvore.proximaArvore;
                        primeiraArvore.segundaArvore = primeiraArvore.segundaArvore.proximaArvore;		
                    }
                    primeiraArvore.segundaArvore = segundaAux;
                    arvoreUltima.proximaArvore = new Arvore();
                    arvoreUltima.proximaArvore.item = item;
                }
                    
            }
        } 

        public Arvore GetItemPrimeiraArvore(ref Arvore primeiraArvore, int posicao){
            //Arvore arvoreAux = new Arvore();
            //arvoreAux.primeiraArvore = primeiraArvore.primeiraArvore;
            //arvoreAux.segundaArvore = primeiraArvore.segundaArvore;
            Arvore arvoreAux = primeiraArvore.primeiraArvore;

            Arvore arvoreAtual = null;
            for (int i=-1; i != posicao; i++){
                arvoreAtual = primeiraArvore.primeiraArvore;
                primeiraArvore.primeiraArvore = primeiraArvore.primeiraArvore.proximaArvore;    
            }
            //primeiraArvore = arvoreAux;
            primeiraArvore.primeiraArvore = arvoreAux;
            return arvoreAtual;
        }
    }
}


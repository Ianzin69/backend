class Program {
   
    public static void Main() {

        string[] produtos = new string[5];
        produtos[4] = "carne 2kg";
        produtos[2] = "linguica 1,5kg";
        produtos[0] = "picanha 2kg";
        produtos[3] = "temperos 1kg";
        produtos[1] = "pao 1kg";

        for (int i = 0; i < produtos.Length; i++) {

            Console.WriteLine($"Os items da lista {i} tem {produtos[i]}");
        }

        foreach (string i in produtos) {

            Console.WriteLine($"tem {i}");
           
        }

        Array.Sort(produtos);

        for (int i = 0; i < produtos.Length; i++) {

            Console.WriteLine($"Os items da lista {i} tem {produtos[i]}");
        }
    }
}

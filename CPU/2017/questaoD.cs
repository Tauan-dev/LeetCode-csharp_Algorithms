using System.Runtime.Serialization.Formatters;

public class Solution
{
    public class Node
    {
        public char data;
        public Node? left;
        public Node? right; // o ? indica que o nó pode ser nulo

        public Node(char data) // constructor da classe
        {
            this.data = data;
            left = null;
            right = null;
        }
    }

    public class BinaryTree
    {
        public Node? root; // nó raiz da árvore
        public BinaryTree()
        {
            root = null; // inicia nó raiz como nulo
        }

        public void Insert(char[] chars)
        {
            if (chars.Length == 0)
            {
                Console.WriteLine("Entrada Vazia");
                return; // caso o texto for vazio, não entra na condição

            }
            Node?[] nodes = new Node?[chars.Length + 1]; // instância a classe Node como um array de nós

            for (int i = 0; i < chars.Length; i++)
            {
                nodes[i + 1] = new Node(chars[i]); // cada caracter inserido vira um nó
            }

            for (int i = 1; i <= chars.Length; i++)
            {
                int leftIndex = 2 * i;
                int rightIndex = 2 * i + 1;

                if (leftIndex <= chars.Length)
                {
                    nodes[i]!.left = nodes[leftIndex]; // ao verificar que existe um nó esquerdo para o nó atual (e sabemos que ele tem, pois foi inserido cada caracter como nó no laço anterior), ele atribui a posição do leftindex como filho desse nó anterior  
                }
                if (rightIndex <= chars.Length)
                {
                    nodes[i]!.right = nodes[rightIndex]; // mesma lógica do nó esquerdo, porém para o nó direito
                }
            }

            root = nodes[1]; // atribui o nó raiz como o primeiro nó do array de nós
        }


        public List<char> InorderTransversal()
        {
            List<char> result = new List<char>();// inicia e instância a list
            InorderRecursive(root, result); // passa o método recursivo usando o root como parametro
            return result; // retorna a lista 
        }

        private void InorderRecursive(Node? node, List<char> result) // dentro do metodo, instância a classe de Node, podendo utilizar seus atributos e indica que o nó pode ser nulo
        {
            if (node != null)
            {
                InorderRecursive(node.left, result);
                result.Add(node.data);
                InorderRecursive(node.right, result);
            }
        }
    }

    public static void Main(string[] args)
    {
        var tree = new BinaryTree(); // instância a classe de binaryTree
        string texto = "Um texto simples";

        char[] caracteres = texto.ToCharArray();//metodo que transforma uma string em um array de Chars

        tree.Insert(caracteres);


        List<char> arvore = tree.InorderTransversal();

        Console.WriteLine(new string(arvore.ToArray())); // new string vai criar uma string apartir de um array de chars e .ToArray converte a Lista em char[]
    }
}
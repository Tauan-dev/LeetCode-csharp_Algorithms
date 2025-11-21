// lógica de Binary Tree Search Inorder para string
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

        public void Insert(char data)
        {
            if (root == null)
            {
                root = new Node(data);
            }
            else
            {
                InsertRecursive(root, data);
            }
        }

        public void InsertRecursive(Node node, char data)
        {
            if (data < node.data) // se o dado inserido for menor que o nó referenciado, entra nessa condição
            {
                if (node.left == null)
                {
                    node.left = new Node(data); //dentro da árvore binária ele verifica se tem algum nó a esquerda, caso não exista  
                }
                else
                {
                    InsertRecursive(node.left, data); // caso exista um nó a esquerda já inserido, ele vai chamar o metodo de forma recursiva. Utilizando o nó a esqurda como referência agora 
                }
            }

            else if (data > node.data) // vai seguir a mesma lógica que antes, porém para os nós a esquerda
            {
                if (node.right == null)
                {
                    node.right = new Node(data);
                }
                else
                {
                    InsertRecursive(node.right, data);
                }

            }
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
        int entradaLength = 16;

        for (int i = 0; i < entradaLength; i++)
        {
            tree.Insert(texto[i]);
        }

        List<char> arvore = tree.InorderTransversal();

        Console.WriteLine(new string(arvore.ToArray())); // new string vai criar uma strinf apartir de um array de chars e .ToArray converte a Lista em char[]
    }
}
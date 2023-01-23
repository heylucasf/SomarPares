Console.WriteLine("Iniciando QUESTAO 01 \nEscreva um algoritmo que some números pares");

List<int> num = new List<int>();
Console.WriteLine("Informe numeros separados por espaço");

var input = Console.ReadLine();
var nums = input.Split(" ");

foreach (var n in nums)
    num.Add(int.Parse(n));
SomarPares(num);

void SomarPares(List<int> num)
{
    int i, j, v1;
    int v2 = Int32.MaxValue;
    String result = "";
    for (i = 0; i < num.Count; i++) {
        for (j = 0; j < num.Count; j++) {
            if (num[i] % 2 == 0 && num[j] % 2 == 0 && num[i] != num[j]) {
                v1 = num[i] + num[j];

                if (v2 > v1) {
                    v2 = v1;
                    result = Convert.ToString(num[i]) + " + " + Convert.ToString(num[j]);
                }
            }
        }
    }
    Console.WriteLine("Resultado: " + result + " = " + v2);
}
Console.Read();
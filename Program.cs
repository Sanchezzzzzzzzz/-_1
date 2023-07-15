void Write(string message){
    Console.WriteLine(message);
}
void InputArr(string[] array, int length){
    for(int i = 0; i < length; i++){
        array[i]=Console.ReadLine()!;
    }
}
void PrintNewArr(string[] array, int length){
    Console.WriteLine(string.Join(",", array.Where(array => array.Length<=3)));
}
Write("Введите размер массива");
int length=int.Parse(Console.ReadLine()!);
Write("Введите массив");
string[] array = new string[length];
InputArr(array, length);
Console.WriteLine();
PrintNewArr(array, length);
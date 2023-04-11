int[] array = {12, 6, 76, 45, 91, 23, 45};

int n = array.Length;
int find = 23;
int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index ++;
}

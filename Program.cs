string[] ArrayOfString = {"asdfsdj", "dfsdaf", "/", "asd", ";adjgji"}, 
         ResultArray = new string[5];
int i, j;
Console.WriteLine($"[{string.Join(", ", ArrayOfString)}]");

for (i = 0, j = 0; i < ArrayOfString.Length; i++) {
    if (ArrayOfString[i].Length <= 3) {
        ResultArray[j] = ArrayOfString[i];
        j++;
    }
}

Console.WriteLine($"[{string.Join(", ", ResultArray)}]");

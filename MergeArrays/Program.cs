// See https://aka.ms/new-console-template for more information

var merge = new MergeArray();
int[] a = new int[] {1,5,6,7,8 };
int[] b = new int[] {2,2,4,6,7,8};

var result = merge.Merge(a,b);

foreach(var r in result)
{
    System.Console.Write(" {0} ",r);
}

System.Console.WriteLine("");
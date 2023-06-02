

public class MergeArray
{

    private void moveNext(ref int[] result, ref int[] array,ref int resultIndex,ref int arrayIndex)
    {
        result[resultIndex] = array[arrayIndex];
        arrayIndex++;
        resultIndex++;
    }

    public int[] Merge(int[] a, int[] b)
    {
        bool next = true;
        int aIndex= 0;
        int bIndex = 0;
        int index = 0;

        int[] result = new int[a.Length + b.Length];
    
        do
        {
            var bothOnBounds = (aIndex < a.Length && bIndex < b.Length);
        
            if( bothOnBounds && (a[aIndex] <= b[bIndex]) )
            {
                moveNext(ref result,ref a,ref index,ref aIndex);
            }
            else if(bothOnBounds &&  (a[aIndex] > b[bIndex]))
            {
                moveNext(ref result,ref b,ref index,ref bIndex);
            }
            else if (aIndex < a.Length)
            {
                moveNext(ref result,ref a,ref index,ref aIndex);
            }
            else if(bIndex < b.Length)
            {
                moveNext(ref result,ref b,ref index,ref bIndex);
            }

            if( aIndex == a.Length && bIndex == b.Length)
                next = false;

        }while(next);

        return result.ToArray();
    }
}
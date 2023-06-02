namespace MergeArrays.Test;

public class MergeArrayShould
{
    [Theory]
    [InlineData(new int[] {},new int[] {}, new int[]{})]
     [InlineData(new int[] {2,10,24,50},new int[] {0,3,5,11,30}, new int[]{0,2,3,5,10,11,24,30,50})]
    [InlineData(new int[] {1,5,6,7,8 },new int[] {5,6,9,10}, new int[]{1,5,5,6,6,7,8,9,10})]
    [InlineData(new int[] {1,5,6,7,8 },new int[] {2,2,4,6,7,8}, new int[]{1,2,2,4,5,6,6,7,7,8,8})]
    public void Merge_Array(int[] a , int[] b , int[] expectedResult)
    {
        // arrange 
        var sut = new MergeArray();

        // act 
        var result = sut.Merge(a,b);

        // assert 
        Assert.Equal(expectedResult,result);

    }
}
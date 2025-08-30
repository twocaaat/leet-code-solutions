using LeetCode.Solutions._006_ZigzagConversion;

namespace LeetCode.Tests._006_ZigzagConversion;

public class ZigzagConversionTests
{
    [Theory]
    [InlineData("PAYPALISHIRING", 3, "PAHNAPLSIIGYIR")]
    [InlineData("PAYPALISHIRING", 4, "PINALSIGYAHRPI")]
    [InlineData("A", 1, "A")]
    [InlineData("PAYPALISHIRINGPAYPALISHIRING", 5, "PHYRASIAPIIYIRPAHNPLIGLSGANI")]
    [InlineData("PAYPALISHIRING", 1, "PAYPALISHIRING")]
    [InlineData("AB", 3, "AB")]
    public void Solution_Test(string s, int numRows, string expectedOutput)
    {
        // arrange
        var solution = new Solution();
        
        // act
        var output = solution.Convert(s, numRows);

        // assert
        Assert.Equal(expectedOutput, output);
    }
}


using Xunit;

public class StringReverserTests
{
    [Fact]
    public void StringReverse()
    {
        // Given
        string input = "abcdef";
        string expectedOutput = "fedcba";
        StringReverser stringReverse = new StringReverser();

        // When
        string result = stringReverse.ReverseString(input);

        // Then
        Assert.Equal(expectedOutput, result);
    }
}

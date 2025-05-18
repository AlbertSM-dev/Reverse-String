public class Solution {
    public void ReverseString(char[] s) 
    {
        int left = 0, right = s.Length - 1;
    
        while (left < right) 
        {
            // Intercambiar los caracteres en las posiciones izquierda y derecha
            char temp = s[left];
            s[left] = s[right];
            s[right] = temp;

            left++;
            right--;
        }       
    }
}

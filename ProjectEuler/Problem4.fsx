open System
let rec isPalindrome (value:string) =
   let length = value.Length
   match value with
    | "" -> true
    |x -> match length with
            | 1 -> true
            | _ -> x.[0] = x.[length - 1] && isPalindrome (x.Substring(1,(length - 2)))
  
let maxPalindrome = 
    let palindromes = seq {
        for i = 999 downto 100 do
            for j = 999 downto 100 do
                let numberString = Convert.ToString(i*j)
                if isPalindrome(numberString) then
                    yield i*j
            
    }
    Seq.max palindromes

printf "%A" maxPalindrome
    





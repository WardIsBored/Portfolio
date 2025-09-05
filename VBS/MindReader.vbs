Dim userInput
userInput = InputBox("Please enter what you're thinking of:", "I can read your mind!")

If userInput <> "" Then
    msg = MsgBox("You're thinking of: " & userInput)
end if
using WordGuesser;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject StartScreen;
    public GameObject PlayScreen;
    public UnityEngine.UI.Text Message;
    public UnityEngine.UI.Button StartButton;
    private WordGuesser.WordGame guessingGame;
    public UnityEngine.UI.InputField PlayerGuess;
    public UnityEngine.UI.Text getWord;
    public UnityEngine.UI.Text GetGuessedLetters;
    public UnityEngine.UI.Text GuessesRemaining;
    public UnityEngine.UI.Text CheckGuess;
    public void ChangeCheckGuess(char guess)
    {
        CheckGuess.text = "Your guess is";
    }
    public void ChangeGuessesRemaining()
    {
        int remaining = this.guessingGame.GetGuessLimit() - this.guessingGame.GetIncorrectGuesses();
        GuessesRemaining.text = $"You have {remaining} guesses remaining.";
    }

    public void ChangegetWord()
    {
        getWord.text = "Some Word";
    }
    public void ChangeGetGuessedLetters()
    {
        GetGuessedLetters.text = "Guessed Letters";
    }
    public void SubmitGuess()
    {
        string result = this.guessingGame.CheckGuess(PlayerGuess.text);
        Debug.Log(result);
    }
    public void StartGame()
    {
        this.guessingGame = new WordGuesser.WordGame("apple", 5);
        Debug.Log(this.guessingGame.GetWord());
        Debug.Log(this.guessingGame.GetFullWord());
        
        this.Message.text = "Can you save the snowman?";
        this.StartButton.gameObject.SetActive(false);
        this.StartScreen.SetActive(false);
        this.PlayScreen.SetActive(true);
    }
    public void OpenStartScreen()
    {
        this.StartScreen.SetActive(true);
        this.PlayScreen.SetActive(false);
    }
    public void Start()
    {
        this.StartScreen.SetActive(true);
        this.PlayScreen.SetActive(false);
    }
}



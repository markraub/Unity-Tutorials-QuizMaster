using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Quiz Question", fileName = "New Question")]  
public class QuestionSO : ScriptableObject
{
    [TextArea(2, 6)]//minimum of 2 lines, maximum of 6
    [SerializeField] string question = "Enter question here";

    [SerializeField] string[] options = new string[4];

    [SerializeField] int answer;
    
    public string GetQuestion()
    {
        return question;
    }

    public int GetAnswerIndex()
    {
        return answer;
    }

    public string GetAnswer(int index)
    {
        return options[index];
    }

    public string[] GetOptions()
    {
        return options;
    }

}

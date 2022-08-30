using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
  ScriptableObject almacena datos persistentes en memoria que puede ser accedido desde cualquier escena o prefab.
  Debe guardarse como un Prefab y no puede adherirse a un componente.
  Es inmutable en la ejecución de un juego, por lo que no sirve para guardar datos en una partida, sino para usar datos almacenados en el desarrollo.
  Como en este caso en donde almacenaremos preguntas y respuestas.
*/
// CreateAssetMenu(...) sirve para crear este script como un asset desde el context menu
[CreateAssetMenu(menuName = "Quiz Question", fileName = "New Question")]
public class QuestionSO : ScriptableObject
{
    [TextArea(2, 6)]
    [SerializeField] string question = "Enter new question text here";
    [SerializeField] string[] answers = new string[4];
    [SerializeField] int correctAnswerIndex;

    public string GetQuestion()
    {
        return question;
    }

    public int GetCorrectAnswerIndex()
    {
        return correctAnswerIndex;
    }

    public string GetAnswer(int index)
    {
        return answers[index];
    }
}

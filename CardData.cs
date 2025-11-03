using UnityEngine;

[CreateAssetMenu(fileName = "card", menuName = "Cards/sonho")]
public class CardData : ScriptableObject
{
    public enum CardTipo{
      pedra, papel,tesoura
     }
    public string Id;
    public string Nome;
    [TextArea] public string Descricao;
    public int Rank, Vida;
    public Sprite Arte;
    public CardTipo Tipo; // enum: Criatura, Feitico, etc.
    public bool InvRaso;
}

using UnityEngine;

public class PowerPellet : Pellet
{
    public float duration = 8f;

    protected override void Eat()
    {
        FindObjectOfType<GameController>().PowerPelletEaten(this);
    }

}

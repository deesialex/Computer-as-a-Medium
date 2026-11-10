using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerAttack : MonoBehaviour
{
    public Animator animator;
    public Animator range;
    public PlayerMana playerMana;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        Attack();
    }
    void Attack()
    {
        if (Mouse.current.leftButton.isPressed)
        {
            animator.SetBool("attack", true);
        }
        else
        {
            animator.SetBool("attack", false);
        }
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            playerMana.mana -= 10;

            if (playerMana.mana < 0)
            {
                playerMana.mana = 0;
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interfaceExample : MonoBehaviour
{
    void Start()
    {
        Warrior warior1 = new Warrior();
        Mage mage1 = new Mage();

        warior1.Attack();
        mage1.Attack();
        mage1.ManaReturn();
    }
}

public interface ICombat // If you need more than one inheritance class you should use interface
{
    void Attack();
}

public interface IMeditaion
{
    void ManaReturn();
}

public class Warrior : ICombat
{
    public void Attack()
    {
        Debug.Log("Savaşçı Kılıç ile saldırıyor");
    }
}

public class Mage : ICombat, IMeditaion
{
    public void Attack()
    {
        Debug.Log("Büyücü büyü ile saldırıyor");
    }

    public void ManaReturn()
    {
        Debug.Log("Büyücü Meditasyon Yapıyor");
    }
}
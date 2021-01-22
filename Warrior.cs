using System;

class Warrior{
    public string Name;
    public int Health;
    public int MaxAttack;
    public int MaxBlock;

public Warrior(string name, int health, int maxAttack, int maxBlock){
    this.Name = name;
    this.Health = health;
    this.MaxAttack = maxAttack;
    this.MaxBlock = maxBlock;
}

public int GetAttack(){
    var random = new Random();
    int randomNum = random.Next(0, MaxAttack);
    return randomNum;
}

public int GetBlock(){
    var random = new Random();
    int randomNum = random.Next(0, MaxBlock);
    return randomNum;
}

public void ApplyDamage(int damage){
    Health = Health - damage;
}

}
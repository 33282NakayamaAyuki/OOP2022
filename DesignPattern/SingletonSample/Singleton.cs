using System;

public class Singleton { //�C���X�^���X�𕡐����Ȃ�����(Hero1 Hero2�͓����ݒ�ƂȂ�)

    private static Singleton singleton;
    
    //�R���X�g���N�^
    private Singleton() {                                 
        Console.WriteLine("�C���X�^���X�𐶐����܂����B");
    }

    public static Singleton getInstance() 
    {
        if (singleton == null) {
            singleton = new Singleton();
        }
        return singleton;
    }
}

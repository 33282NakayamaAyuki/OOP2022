using System;

public class Singleton { //インスタンスを複数作らなくする(Hero1 Hero2は同じ設定となる)

    private static Singleton singleton;
    
    //コンストラクタ
    private Singleton() {                                 
        Console.WriteLine("インスタンスを生成しました。");
    }

    public static Singleton getInstance() 
    {
        if (singleton == null) {
            singleton = new Singleton();
        }
        return singleton;
    }
}

using System;
using System.Collections.Generic;

// 나라이름, 환율을 나타내는 클래스
class Currency
{
    public string Title { get; set; }
    public double Rate { get; set; }
}

// 모델 : 데이타를 가진 클래스
//        DB, File 등을 통해서 얻은 데이타를 보관
//        여기서는 WPF 의 기술을 사용하지 마세요
//        모델 자체는 다른 곳에서도 활용 가능하고, 쉽게 테스트 할수 있어야 합니다.
class Model
{
    public List<Currency> clist = new List<Currency>();

    public Model()
    {
        clist.Add(new Currency { Title = "USA", Rate = 1500 });
        clist.Add(new Currency { Title = "Japan", Rate = 800 });
        clist.Add(new Currency { Title = "Euro", Rate = 1400 });
    }

    public List<Currency> GetList() {  return clist; }
}
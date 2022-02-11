package com.company;


public class Watch implements SmartWatch{
    public String name;
    public String dialType;
    public int timeFormat;
    public Watch(String name, String dialType, int timeFormat){
        this.name = name;
        this.dialType = dialType;
        this.timeFormat = timeFormat;
    }
    public Watch(){}
    protected void SetName(String newName){
        if(newName.length()==0 | newName == " "){
            System.out.println("Название часов не может быть пустым");

        }
        else{
            this.name = newName;
        }
    }
    public String GetName(){
        return name;
    }
    protected void SetDialType(String newDialType){
        if(newDialType.length()==0 | newDialType == " "){
            System.out.println("Тип циферблата не может быть пустым не может быть пустым");

        }
        else{
            this.dialType = newDialType;
        }
    }
    public String GetDialType(){
        return dialType;
    }

    protected void SetTimeFormat(int newTimeFormat){
        if(newTimeFormat == 0){
            System.out.println("Тип формата не может быть пустым или равняться нулю");

        }
        else{
            this.timeFormat = newTimeFormat;
        }
    }
    public int GetTimeFormat(){
        return timeFormat;
    }

    public void SetSmartWatchName(String s){
        this.name = s;
    }
    public String GetSmartWatchName(){
        return name;
    }

    public void SetMatrixType(String s){
        this.dialType = s;
    }
    public String GetMatrixType(){
        return dialType;
    }
    public void SetInbuiltMemory(int capacity){
        this.timeFormat = capacity;
    }
    public int GetInbuiltMemory(){
        return timeFormat;
    }

    //Передача интерфейса в качестве аргумента метода
    static void read(SmartWatch some){
        some.print();
    }

    @Override
    public void print() {
        System.out.println("Производитель смарт-часов "+ name + " Тип экрана " + dialType + " Объём встоенной памяти "+ timeFormat);
    }

    @Override
    public String toString() {
        return "Часы традиционные " +
                "Название " + name +
                " Тип циферблата " + dialType +
                " Врменной формат " + timeFormat;
    }
}

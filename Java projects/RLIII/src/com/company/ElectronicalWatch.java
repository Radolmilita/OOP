package com.company;


//Реализует интерфейс через родительский класс
public class ElectronicalWatch extends Watch implements SmartWatch{
    public String formFactor;
    public String displayType;
    protected void SetFormFactor(String newForm){
        this.formFactor = newForm;
    }
    public String GetFormFactor(){
        return formFactor;
    }

    protected void SetDisplayType(String newDisplayType){
        this.displayType = newDisplayType;
    }
    public String GetDisplayType(){
        return displayType;
    }

    public void print(){
        System.out.println("Название часов "+GetName()+" Тип дисплэя "+GetDisplayType()+" Форм фактор " + GetFormFactor());
    }
}

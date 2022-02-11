package com.company;

import org.jetbrains.annotations.NotNull;

import java.io.Serializable;
import java.time.Instant;

public class RecreationPlaces implements Serializable {

    public transient RecreationType hotelType;
    public String placeName;
    public int priceForOnePerson;
    public int peopleAmount;

    //implicit constructor (default)
    public RecreationPlaces(){
    }
    //explicit constructor
    public RecreationPlaces(String placeName, int priceForOnePerson, int peopleAmount) {
        this.peopleAmount = peopleAmount;
        this.placeName = placeName;
        this.priceForOnePerson = priceForOnePerson;
    }

    //explicit constructor
    public RecreationPlaces(String placeName, int priceForOnePerson, int peopleAmount, RecreationType type) {
        hotelType = type;
        this.peopleAmount = peopleAmount;
        this.placeName = placeName;
        this.priceForOnePerson = priceForOnePerson;
    }

    //getters and setters

    public void setPlaceName(@NotNull String newName){
        if(newName.length()==0 | newName == " "){
           System.out.println("Название отеля не может быть пустым");

        }
        else{
            this.placeName = newName;
        }
    }

    public String getPlaceName(){
        return placeName;
    }

    protected void setPriceForOnePerson(int newPrice){
        this.priceForOnePerson = newPrice;
    }

    public int getPriceForOnePerson(){
        return priceForOnePerson;
    }

    public String showWithType(RecreationPlaces somePlace){
        switch (somePlace.hotelType){
            case RESORT:
                return somePlace.toString()+ " Hotel type: resort";
            case APART:
                return somePlace.toString()+ " Hotel type: apartments";
            case HOSTEL:
                return somePlace.toString()+ " Hotel type: hostel";
            case BUSINESS:
                return somePlace.toString()+ " Hotel type: business";

        }
        return "No matched type";
    }

    protected void setPeopleAmount(int newAmount){ peopleAmount = newAmount; }
    public int getPeopleAmount(){return peopleAmount;}

    public Instant getCreationTime(){
        Instant now = Instant.now();
        return now;
    }



    @Override
    public String toString() {
        return "Места отдыха" + '\n'+
                "Название отеля " + placeName +
                " Цена за 1 человека " + priceForOnePerson +
                " Количество мест " + peopleAmount;
    }
}

enum RecreationType{
    RESORT ("resort"),
    BUSINESS ("business"),
    APART ("apart"),
    HOSTEL ("hostel");

    private String title;


    RecreationType(String title) {
        this.title = title;
    }

    public String getType() {
        return title;
    }
}
package com.company;

import java.io.*;
import java.util.ArrayList;
import java.time.Duration;
import java.time.Instant;

import static com.company.RecreationType.*;

public class Main {

    public static void main(String[] args) throws InterruptedException {
        RecreationPlaces littleHotel = new RecreationPlaces("Hilton", 2000, 200);
        System.out.println(littleHotel);
        RecreationPlaces otherHoltel = new RecreationPlaces();
        System.out.println(otherHoltel);


        RecreationPlaces qualia = new RecreationPlaces();
        qualia.setPlaceName("Qualia Australia");
        qualia.setPriceForOnePerson(5000);
        qualia.setPeopleAmount(200);
        System.out.println("Hotel name " + qualia.getPlaceName() + " Price for person " +
                qualia.getPriceForOnePerson() + " Place amount " + qualia.getPeopleAmount());

        //Hotel type with enum
        RecreationPlaces kauriCliffs = new RecreationPlaces("Kauri Cliffs",4000,
                24, RESORT);
        System.out.println(kauriCliffs.showWithType(kauriCliffs));

        Instant currentTime = Instant.now();
        Thread.sleep(10000);
        Duration timeElapsed = Duration.between(currentTime, kauriCliffs.getCreationTime());
        System.out.println("Time elspsed " + timeElapsed.toMillis());


        ArrayList<RecreationPlaces> topHotels = new ArrayList<RecreationPlaces>();
        topHotels.add(new RecreationPlaces("Hotel Caesar Augustus",3000,55));
        topHotels.add(new RecreationPlaces("Palazzo Avino" , 2400, 20));
        topHotels.add(new RecreationPlaces("Sabi Sabi Private Game Reserve", 6000, 40) );
        topHotels.add(  new RecreationPlaces("Peninsula House",7000,25));

        String filename = "hotels.bin";

        try(ObjectOutputStream oos = new ObjectOutputStream(new FileOutputStream(filename)))
        {
            oos.writeObject(topHotels);
            System.out.println("File has been written");
        }
        catch(Exception ex){

            System.out.println(ex.getMessage());
        }

        // десериализация в новый список
        ArrayList<RecreationPlaces> newTopHotels= new ArrayList<RecreationPlaces>();
        try(ObjectInputStream ois = new ObjectInputStream(new FileInputStream(filename)))
        {

            newTopHotels=((ArrayList<RecreationPlaces>)ois.readObject());
        }
        catch(Exception ex){

            System.out.println(ex.getMessage());
        }

        for(RecreationPlaces rp : newTopHotels)
            System.out.println("Назвчание отеля: " + rp.getPlaceName() +" Цена за человека: " + rp.getPriceForOnePerson() +" Количество номеров: "+rp.getPeopleAmount());

        int apartsIndex = RecreationType.APART.ordinal();
        System.out.println(apartsIndex);
    }
}

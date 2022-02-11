package com.company;

public class Student {
    public static final String ANSI_RED = "\u001B[31m";
    public static final String ANSI_RESET = "\u001B[0m";


    public String studentName;
    public int numberOfRecordBook;
    public int group;
    public Student(String studentName, int numberOfRecordBook, int group){
        this.studentName = studentName;
        this.numberOfRecordBook = numberOfRecordBook;
        this.group = group;
    }
    public String getName(){
        return studentName;
    }

    @Override
    public String toString() {
        return
                ANSI_RED + "Student name: "+ANSI_RESET + studentName +
                        ANSI_RED +" record book number "+ANSI_RESET + numberOfRecordBook +
                        ANSI_RED + " group " +ANSI_RESET + group;
    }
}

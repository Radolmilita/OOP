package com.company;

public class Main {

    public static void main(String[] args) {
        Group myGroup = new Group();
        myGroup.fillGroup();

        myGroup.displayStudent();

        Subject oop = new Subject(myGroup, "OOP", 5, 0.2);
        myGroup.addSubject(oop);
        myGroup.addSubject("Численные методы", 3, 0.2);

        System.out.println(oop.toString());

        try {
            myGroup.getSubject("OOP").markAttendance(0);
            myGroup.getSubject("Численные методы").markAttendance(0);
            myGroup.getSubject("OOP").markAttendance(1);
            myGroup.getSubject("Численные методы").markAttendance(1);

            myGroup.getSubject("Численные методы").putMark(myGroup.getStudent("Димитриев Валерий Вадимович"), 0, 5);
            myGroup.getSubject("Численные методы").putMark(myGroup.getStudent("Можар Полина Александровна"), 0, 4);
            myGroup.getSubject("Численные методы").putMark(myGroup.getStudent("Димитриев Валерий Вадимович"), 1, 8);
            myGroup.getSubject("Численные методы").putMark(myGroup.getStudent("Можар Полина Александровна"), 1, 9);

            myGroup.getSubject("Численные методы").markStudent(myGroup.getStudent("Димитриев Валерий Вадимович"), 2);
            myGroup.getSubject("Численные методы").markStudent(myGroup.getStudent("Можар Полина Александровна"), 2);
        } catch (Exception e) {
            e.printStackTrace();
        }

        System.out.println(myGroup.formPresences());
        System.out.println(myGroup.formMarks());

        System.out.println(myGroup.formMarksByStudent(myGroup.getStudent("Можар Полина Александровна")));
        System.out.println(myGroup.formPresenceByStudent(myGroup.getStudent("Димитриев Валерий Вадимович")));

        try {
            System.out.println(myGroup.getSubject("OOP").displayPresenceByStudent(myGroup.getStudent("Димитриев Валерий Вадимович")));
            System.out.println(myGroup.getSubject("OOP").displayMarksByStudent(myGroup.getStudent("Можар Полина Александровна")));
        } catch (Exception e) {
            e.printStackTrace();
        }


    }
}

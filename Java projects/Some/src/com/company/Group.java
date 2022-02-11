package com.company;

import java.util.ArrayList;

public class Group {
    ArrayList<Student> studentsArrayList = new ArrayList<Student>();
    ArrayList<Subject> subjects = new ArrayList<Subject>();
    public void fillGroup () {
        studentsArrayList.add(new Student("Димитриев Валерий Вадимович", 22120801, 208));
        studentsArrayList.add(new Student("Хоменко Дмитрий Сергеевич", 22120803, 208));
        studentsArrayList.add(new Student("Можар Полина Александровна", 22112613, 208));
        studentsArrayList.add(new Student("Димитриев Валерий Николаевич", 22120812, 209));
        studentsArrayList.add(new Student("Кушниров Алексей Викторович", 21009212, 209));
    }
    public ArrayList getStudentList(){
        return studentsArrayList;
    }

    public Student getStudent(String name){
        for (Student item:
                studentsArrayList) {
            if(item.getName().compareTo(name)==0){
                return item;
            }
        }
        return null;
    }

    public void addSubject(Subject subject){
        subjects.add(subject);
    }
    public void addSubject(String name, int credits, double ratio){
        subjects.add(new Subject(this, name, credits, ratio));
    }

    public ArrayList<Subject> getSubjects(){
        return subjects;
    }

    public Subject getSubject(String name) throws Exception {
        for (Subject subject: subjects){
            if (subject.getSubjectName() == name) return subject;
        }
        throw new Exception("No such subject as " + name + "!");
    }
    public void displayStudent() {
        for (Student item: studentsArrayList) {
            System.out.println(item);
        }
    }

    public String formPresences(){
        StringBuilder sb = new StringBuilder();

        for (Subject subject: subjects){
            sb.append(subject.getSubjectName()+"\n");
            sb.append(subject.displayPresence());
        }
        return sb.toString();
    }

    public String formMarks(){
        StringBuilder sb = new StringBuilder();

        for (Subject subject: subjects){
            sb.append(subject.getSubjectName()+"\n");
            sb.append(subject.displayMarks());
        }
        return sb.toString();
    }

    public String formMarksByStudent(Student student){
        StringBuilder sb = new StringBuilder();

        for (Subject subject: subjects){
            sb.append(subject.getSubjectName()+"\n");
            sb.append(subject.displayMarksByStudent(student));
        }
        return sb.toString();
    }

    public String formPresenceByStudent(Student student){
        StringBuilder sb = new StringBuilder();

        for (Subject subject: subjects){
            sb.append(subject.getSubjectName()+"\n");
            sb.append(subject.displayPresenceByStudent(student));
        }
        return sb.toString();
    }
}


#ifndef VOTER_H
#define	VOTER_H

#ifdef	__cplusplus
extern "C" {
#endif

#include "Vote.h"
#include "Gender.h"
#include "Ethnos.h"

    using namespace std;
    using namespace Enums;

    class Voter {
    private:
        string _name;
        string _city;
        int _age;
        Gender _gender;
        Vote _vote;
        Ethnos _ethnos;
    public:
        Voter(string name,int age, string city, Gender gender, Ethnos ethnos, Vote vote){
           this->_name = name;
           this->_age = age;
           this->_city = city;
           this->_gender = gender;
           this->_ethnos = ethnos;
           this->_vote = vote;
        }
        
        string name(){return this->_name;}
        string city(){return this->_city;}
        int age(){return this->_age;}
        Gender gender(){return this->_gender;}
        Ethnos ethnos(){return this->_ethnos;}
        Vote vote(){return this->_vote;}
    };


#ifdef	__cplusplus
}
#endif

#endif	/* VOTER_H */


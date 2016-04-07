"use strict";

angular.module('myFilters', [])
    .filter({
        unique: ['$parse', function ($parse) {
            return function (collection, property) {

                if (!Array.isArray(collection)) {
                    return collection;
                }

                //store all unique identifiers
                var uniqueItems = [],
                    get = $parse(property);

                return (isUndefined(property))
                    //if it's a kind of primitive array
                    ? collection.filter(function (elm, pos, self) {
                    return self.indexOf(elm) === pos;
                })
                    //else compare with equals
                    : collection.filter(function (elm) {
                    var prop = get(elm);
                    if (some(uniqueItems, prop)) {
                        return false;
                    }
                    uniqueItems.push(prop);
                    return true;
                });

                //check if the unique identifier already exists
                function some(array, member) {
                    if (isUndefined(member)) {
                        return false;
                    }
                    return array.some(function (el) {
                        return el === member;
                    });
                }

                function isUndefined(property){
                    return property === 'undefined';
                }
            }
        }]
    })
    .filter({
        timeFormat: [function () {
            return function (value) {
                var hours = value.hours < 10 ? '0' + value.hours : value.hours;
                var minutes = value.minutes < 10 ? '0' + value.minutes : value.minutes;
                var seconds = value.seconds < 10 ? '0' + value.seconds : value.seconds;
                return hours + ":" + minutes + ":" + seconds;
            }
        }]
    });
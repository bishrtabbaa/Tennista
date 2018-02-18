import { Component } from '@angular/core';

@Component({
    selector: 'player'
})
export class Player {
    public name = "Roger Federer";
    public grandSlamsWon = 20;
    public backhandStyleType = "DBL";
    public preferredHandType = "RH";
    public dateOfBirth = new Date("8/21/1976");
    public placeOfBirth = "Basel, Switzerland";
}
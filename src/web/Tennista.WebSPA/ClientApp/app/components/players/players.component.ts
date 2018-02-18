import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';
import { Player } from './player.component';

@Component({
    selector: 'players',
    templateUrl: './players.component.html'
})
export class PlayersComponent {
    public players: Player[];

    constructor() {
        this.players = [];
        this.players.push(new Player());
        this.players.push(new Player());
    }
}


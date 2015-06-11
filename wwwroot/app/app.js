/// <reference path="../../typings/ember/ember.d.ts"/>
app = Ember.Application.create({
    LOG_TRANSITIONS: true
});

app.ApplicationAdapter = DS.RESTAdapter.extend({
    namespace: "api"
});

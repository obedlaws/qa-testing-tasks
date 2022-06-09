
/**  Pre-Requests Script
Here a variable was created to publish a random word or name in a tweet.
*/

var test = pm.variables.replaceIn('{{$randomFirstName}}')
pm.environment.set('pre_twt', test)

// Setting Variables
const twt = pm.environment.get('pre_twt');

// Tests
pm.test("Status code should be 201", ()=> {
    pm.response.to.have.status(201);
});

pm.test("Should include tweet id", ()=>{
    pm.expect(pm.response.text()).to.include('id')
})

pm.test("Should include tweet text", ()=>{
    pm.expect(pm.response.text()).to.include('text')
})
//Pre-Request Scripts
const getUser = ()=>{
    Name = ['pokralaf', 'anjsq3', 'bhdseqwe']
    var result = getRandom(3);
    var user = pm.variables.replaceIn(Name[result]);
    return user
}

const getRandom = (max)=>{
    return Math.floor(Math.random() * max);
}

pm.environment.set('name', getUser())


// Tests
pm.test("Status code should be 200", ()=> {
    pm.response.to.have.status(200);
})

pm.test("Should include message 'Could not find user'",()=>{
    pm.expect(pm.response.text()).to.include('Could not find user with username')
})

pm.test("Title should say 'Not Found Error'", ()=>{
    const response = pm.response.json()
    const title = response.errors[0].title;
    pm.expect(pm.response.text()).to.include(title)
})
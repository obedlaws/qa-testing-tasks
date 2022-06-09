pm.test("Status code should be 401", ()=>{
    pm.response.to.have.status(401);
})

pm.test("Title should say 'Unauthorized'", ()=>{
    const response = pm.response.json();
    const title = response.title;
    pm.expect(title).to.eql('Unauthorized');
})


/**
 * The response by the endpoint should always be the same when treating an unathorized request from 
 * an user that doesn't have a key or ket without the necessary permissions. 
 */